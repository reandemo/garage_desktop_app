namespace Store_Online.Modules.Garage.Models
{
    public class GarageMenuItem
    {
        public string Code { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Icon { get; set; } = string.Empty;

        public bool IsSelected { get; set; }

        public bool IsEnabled { get; set; } = true;

        public object? Tag { get; set; }
    }
}
