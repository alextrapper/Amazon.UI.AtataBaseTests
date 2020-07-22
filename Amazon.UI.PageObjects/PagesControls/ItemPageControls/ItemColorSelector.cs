using Atata;
using Amazon.UI.PageObjects.Pages;

namespace Amazon.UI.PageObjects.PagesControls.ItemPageControls
{
    public class ItemColorSelector : Control<ItemPage>
    {
        public ItemPage SelectColor(string itemsColor)
            => ProductColors.Items[c => 
                c.Content.Value.Equals($"Click to select {itemsColor}")]
            .ColorImagePreview.Click();

        [FindByCss("#variation_color_name ul")]
        private ItemsControl<ColorListItem, ItemPage> ProductColors { get; set; }

        [ControlDefinition("li")]
        [ContentSource("title")]
        [WaitForDocumentReadyState(TriggerEvents.AfterAnyAction, AppliesTo = TriggerScope.Children)]
        [Wait(10, AppliesTo = TriggerScope.Children)]
        class ColorListItem : Control<ItemPage> 
        {
            [FindByClass("imgSwatch")]
            internal Image<ItemPage> ColorImagePreview { get; set; }

            [FindByCss("span.twisterSwatchPrice")]
            internal Text<ItemPage> Price { get; set; }
        }
    }
}
