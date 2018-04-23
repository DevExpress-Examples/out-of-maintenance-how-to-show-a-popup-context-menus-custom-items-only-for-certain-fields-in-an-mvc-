function MenuItemPopUpHandle(s, e) {
    //debugger;
    if (pivotGrid.cpAllowedFields) {
        var str = new String(pivotGrid.cpAllowedFields);
        var arr = str.split('|');
        for (var i = 0; i < arr.length; i++) {
            if (arr[i] == pivotGrid.fieldMenuFieldID) {
                e.item.menu.GetItemByName('Filter').SetVisible(false)
                break;
            }
        }
        var count = 0;
        for (var i = 0; i < e.item.menu.GetItemCount() ; i++) {
            if (e.item.menu.GetItem(i).GetVisible())
                count++;
        }
        if (count == 0)
            s.Hide();
    }
}
function MenuItemCloseUpHandle(s, e) {
    e.item.menu.GetItemByName('Filter').SetVisible(true);
}

function MenuItemClick(s, e)
{
    pivotGrid.PerformCallback(
        {
            menuItemName: e.MenuItemName,
            fieldID: e.FieldID,
            fieldValueIndex: e.FieldValueIndex
        });
    //pivotGrid.PerformCallback("MenuItemClick|" + e.MenuItemName + "|" + e.FieldID + "|" + e.FieldValueIndex);
}