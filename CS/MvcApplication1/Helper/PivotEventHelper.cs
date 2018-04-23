using DevExpress.Web;
using DevExpress.Web.Mvc;
using DevExpress.XtraPivotGrid;
using System;
using System.Linq;
using System.Text;

namespace MvcApplication1.Helper
{
    public class PivotEventHelper
    {
        public static void HandleAfterPerformCallback(PivotGridSettings settings, string fieldID, int itemIndex)
        {
            settings.AfterPerformCallback = (s, e) =>
            {
                MVCxPivotGrid pivot = (MVCxPivotGrid)s;
                MVCxPivotGridField clickedField = (MVCxPivotGridField)pivot.Fields[fieldID];
                object filterValue = pivot.GetFieldValueByIndex(clickedField, itemIndex);
                clickedField.FilterValues.ValuesIncluded = new Object[] { filterValue };
            };
        }
        public static void PassAllowedFieldsToClientSide(PivotGridSettings settings)
        {
            StringBuilder stb = new StringBuilder();
            foreach (MVCxPivotGridField field in settings.Fields.OfType<MVCxPivotGridField>().Where(f => f.Area == PivotArea.DataArea))
            {
                stb.Append(field.ID);
                stb.Append("|");
            }
            settings.CustomJsProperties = (s, e) => { e.Properties.Add("cpAllowedFields", stb.ToString()); };
        }
        public static void CustomizeContextMenu(PivotGridSettings settings)
        {
            settings.PopupMenuCreated = (s, e) =>
            {
                if (e.MenuType == DevExpress.Web.ASPxPivotGrid.PivotGridPopupMenuType.FieldValueMenu)
                {
                    MenuItem item = e.Menu.Items.Add("Filter By This Value", "Filter");
                    item.BeginGroup = true;
                    e.Menu.ClientSideEvents.PopUp = "function ASPxClientMenuItemEventHandler(s, e) { MenuItemPopUpHandle(s, e); }";
                    e.Menu.ClientSideEvents.CloseUp = "function ASPxClientMenuItemEventHandler(s, e) { MenuItemCloseUpHandle(s, e); }";
                }
            };
        }
    }
}