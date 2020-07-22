using Atata;

namespace Amazon.UI.PageObjects.PagesControls.SearchResultPageControls
{
    [ControlDefinition(".//div[@id='departments']")]
    public class DepartmentGroup<TOwner> : Control<TOwner>
        where TOwner : Page<TOwner>
    {
        public TOwner SelectDepartment(string departmentName)
        {
            var departmentToSelect = Departments.Items[item => item.Content.Value.Contains(departmentName)];
            if (!departmentToSelect.IsEnabled) 
            {
                ExpandAllDepartments();
            }
            return departmentToSelect.Click();
        }

        public TOwner ExpandAllDepartments()
            => ExpanderPrompt.Content.Value.Contains("See All")
                ? ExpanderToggler.Click()
                : Owner;

        public TOwner CollapceDepartments()
            => ExpanderPrompt.Content.Value.Contains("Fewer")
                ? ExpanderToggler.Click()
                : Owner;
        
        private UnorderedList<ListItem<TOwner>, TOwner> Departments { get; set; }
                
        [FindByCss("a[data-action='a-expander-toggle']")]
        private Clickable<TOwner> ExpanderToggler { get; set; }

        [FindByCss("a-expander-prompt")]
        private Clickable<TOwner> ExpanderPrompt { get; set;}
    }
}
