namespace AutomationTests.Pages.DroppablePage
{
    internal static class Constants
    {
        //// Common
        internal const string DROPPABLE_URL = "http://demoqa.com/droppable/";
        internal const int WAIT_SECCONDS = 20;

        //// Selectors
        internal const string DEFAULT_TAB_SELECTOR = "ui-id-1";
        internal const string ACCEPT_TAB_SELECTOR = "ui-id-2";
        internal const string PREVENT_PROPAGATION_TAB_SELECTOR = "ui-id-3";
        internal const string REVERT_DRAGGABLE_POSITION_TAB_SELECTOR = "ui-id-4";
        internal const string SHOPING_CART_DEMO_TAB_SELECTOR = "ui-id-5";
        internal const string DRAGGABLE_VIEW_SELECTOR = "draggableview";
        internal const string DROPPABLE_VIEW_SELECTOR = "//*[@id=\"droppableview\"]/p";
        internal const string DRAGGABLE_NON_VALID_SELECTOR = "draggable-nonvalid";
        internal const string DROPPABLE_ACCEPT_SELECTOR = "//*[@id=\"droppableaccept\"]/p";
        internal const string DRAGGABLE_PROP_SELECTOR = "draggableprop";
        internal const string INNER_DROPPABLE_GREEDY_SELECTOR = "//*[@id=\"droppable2-inner\"]/p";
        internal const string OUTER_DROPPABLE_SELECTOR = "//*[@id=\"droppableprop2\"]/p";
        internal const string DRAGGABLE_REVERT_SELECTOR = "draggablerevert";
        internal const string DROPPABLE_REVERT_SELECTOR = "//*[@id=\"droppablerevert\"]/p";
        internal const string PRODUCT_SELECTOR = "//*[@id=\"ui-id-7\"]/ul/li[3]";
        internal const string SHOPPING_CART_SELECTOR = "//*[@id=\"cart\"]/div/ol/li";

        //// Labels
        internal const string DROPPED = "Dropped!";
    }
}
