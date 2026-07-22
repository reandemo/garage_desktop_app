namespace Store_Online.Modules.Garage.Models
{
    public class GarageMenuGroup
    {
        public string Code { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Icon { get; set; } = string.Empty;

        public bool IsExpanded { get; set; }

        public bool IsSelected { get; set; }

        public bool IsEnabled { get; set; } = true;

        public List<GarageMenuItem> Items { get; set; } = new();
    }
}
