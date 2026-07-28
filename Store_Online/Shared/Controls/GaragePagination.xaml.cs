using Store_Online.Shared.Models;
using System.Windows;
using System.Windows.Controls;

namespace Store_Online.Shared.Controls
{
    public partial class GaragePagination : UserControl
    {
        public PaginationModel Pagination { get; } = new();

        public event EventHandler? PageChanged;

        public GaragePagination()
        {
            InitializeComponent();

            Loaded += GaragePagination_Loaded;
        }

        private void GaragePagination_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        public void SetTotalRecords(int totalRecords)
        {
            Pagination.TotalRecords = totalRecords;

            if (Pagination.CurrentPage > Pagination.TotalPages)
            {
                Pagination.CurrentPage = Pagination.TotalPages;
            }

            Refresh();
        }

        public void Refresh()
        {
            txtCurrentPage.Text = Pagination.CurrentPage.ToString();
            txtTotalPages.Text = Pagination.TotalPages.ToString();

            txtSummary.Text =
                $"Showing {Pagination.StartRecord}-{Pagination.EndRecord} of {Pagination.TotalRecords} records";

            btnFirst.IsEnabled = Pagination.CurrentPage > 1;
            btnPrevious.IsEnabled = Pagination.CurrentPage > 1;

            btnNext.IsEnabled = Pagination.CurrentPage < Pagination.TotalPages;
            btnLast.IsEnabled = Pagination.CurrentPage < Pagination.TotalPages;
        }

        private void RaisePageChanged()
        {
            Refresh();

            PageChanged?.Invoke(this, EventArgs.Empty);
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            if (Pagination.CurrentPage == 1)
                return;

            Pagination.CurrentPage = 1;

            RaisePageChanged();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (Pagination.CurrentPage <= 1)
                return;

            Pagination.CurrentPage--;

            RaisePageChanged();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (Pagination.CurrentPage >= Pagination.TotalPages)
                return;

            Pagination.CurrentPage++;

            RaisePageChanged();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            if (Pagination.CurrentPage == Pagination.TotalPages)
                return;

            Pagination.CurrentPage = Pagination.TotalPages;

            RaisePageChanged();
        }

        private void cboPageSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!IsLoaded)
                return;

            if (cboPageSize.SelectedItem is not ComboBoxItem item)
                return;

            if (!int.TryParse(item.Content?.ToString(), out int pageSize))
                return;

            Pagination.PageSize = pageSize;
            Pagination.CurrentPage = 1;

            RaisePageChanged();
        }
    }
}