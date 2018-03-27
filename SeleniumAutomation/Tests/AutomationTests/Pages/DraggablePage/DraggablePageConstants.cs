namespace AutomationTests.Pages.DraggablePage
{
    internal static class Constants
    {
        //// Common
        internal const string DRAGGABLE_URL = "http://demoqa.com/draggable/";
        internal const int WAIT_SECCONDS = 20;

        //// Selectors
        internal const string DEFAULT_TAB_SELECTOR = "ui-id-1";
        internal const string CONSTRAIN_MOVEMENT_TAB_SELECTOR = "ui-id-2";
        internal const string CURSOR_STYLE_TAB_SELECTOR = "ui-id-3";
        internal const string EVENTS_TAB_SELECTOR = "ui-id-4";
        internal const string DRAGGABLE_AND_SORTABLE_TAB_SELECTOR = "ui-id-5";
        internal const string BODY_ELEMENT = "body";
        internal const string DEFAULT_DRAG_ELEMENT = "draggable";
        internal const string CONSTRAINT_MOVEMENT_ELEMENT = "draggabl2";
        internal const string CURSOR_STYLE_ELEMENT = "drag";
        internal const string DRAG_EVENT_ELEMENT = "dragevent";
        internal const string EVENT_START_ELEMENT = "//*[@id=\"event-start\"]/span[2]";
        internal const string EVENT_DRAG_ELEMENT = "//*[@id=\"event-drag\"]/span[2]";
        internal const string EVENT_STOP_ELEMENT = "//*[@id=\"event-stop\"]/span[2]";
        internal const string DRAGGABLE_BOX_ELEMENT = "draggablebox";
        internal const string DRAG_ME_DOWN_ELEMENT = "//*[@id=\"sortablebox\"]/li[6]";
    }
}
