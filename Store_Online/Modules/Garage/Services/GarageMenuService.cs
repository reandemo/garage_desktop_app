using Store_Online.Modules.Garage.Models;

namespace Store_Online.Modules.Garage.Services
{
    public sealed class GarageMenuService
    {
        private static readonly Lazy<GarageMenuService> _instance =
            new(() => new GarageMenuService());

        public static GarageMenuService Instance => _instance.Value;

        private GarageMenuService()
        {
        }

        public List<GarageMenuGroup> MenuGroups { get; } = new();

        public GarageMenuGroup? CurrentGroup { get; private set; }

        public GarageMenuItem? CurrentItem { get; private set; }

        public event EventHandler<GarageMenuItem>? MenuChanged;

        public void Register(IEnumerable<GarageMenuGroup> groups)
        {
            MenuGroups.Clear();
            MenuGroups.AddRange(groups);

            CurrentGroup = null;
            CurrentItem = null;
        }

        public void Select(string itemCode)
        {
            ClearSelection();

            foreach (var group in MenuGroups)
            {
                var item = group.Items.FirstOrDefault(x => x.Code == itemCode);

                if (item == null)
                    continue;

                group.IsExpanded = true;
                group.IsSelected = true;

                item.IsSelected = true;

                CurrentGroup = group;
                CurrentItem = item;

                MenuChanged?.Invoke(this, item);
                return;
            }
        }

        public GarageMenuGroup? FindGroup(string groupCode)
        {
            return MenuGroups.FirstOrDefault(x => x.Code == groupCode);
        }

        public GarageMenuItem? FindItem(string itemCode)
        {
            return MenuGroups
                .SelectMany(x => x.Items)
                .FirstOrDefault(x => x.Code == itemCode);
        }

        public void ClearSelection()
        {
            CurrentGroup = null;
            CurrentItem = null;

            foreach (var group in MenuGroups)
            {
                group.IsSelected = false;

                foreach (var item in group.Items)
                {
                    item.IsSelected = false;
                }
            }
        }
    }
}