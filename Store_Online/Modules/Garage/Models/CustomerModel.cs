using System.Windows.Media;

namespace Store_Online.Modules.Garage.Models
{
    public class CustomerModel
    {
        #region Save

        /// <summary>
        /// I = Insert
        /// U = Update
        /// </summary>
        public string Command { get; set; } = "I";

        public string BranchCode { get; set; } = string.Empty;

        /// <summary>
        /// Customer Code (CUS000001...)
        /// </summary>
        public string CustomerId { get; set; } = string.Empty;

        public string CustomerName { get; set; } = string.Empty;

        public string? Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? Province { get; set; }

        public string? Remark { get; set; }

        public string Status { get; set; } = "Active";

        public string CreatedBy { get; set; } = string.Empty;

        #endregion

        #region Grid

        public int No { get; set; }

        public int VehicleCount { get; set; }

        #endregion

        #region Status Color

        private static readonly Brush ActiveBrush =
            new SolidColorBrush(Color.FromRgb(46, 125, 50));

        private static readonly Brush InactiveBrush =
            new SolidColorBrush(Color.FromRgb(198, 40, 40));

        private static readonly Brush PendingBrush =
            new SolidColorBrush(Color.FromRgb(245, 124, 0));

        private static readonly Brush DefaultBrush =
            new SolidColorBrush(Color.FromRgb(117, 117, 117));

        public Brush StatusColor =>
            Status switch
            {
                "Active" => ActiveBrush,
                "Inactive" => InactiveBrush,
                "Pending" => PendingBrush,
                _ => DefaultBrush
            };

        #endregion
    }
}
