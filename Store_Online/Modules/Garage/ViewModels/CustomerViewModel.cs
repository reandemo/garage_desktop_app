using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Store_Online.Core.Logging;
using Store_Online.Modules.Garage.Models;
using Store_Online.Modules.Garage.Repositories;

namespace Store_Online.Modules.Garage.ViewModels
{
    public class CustomerViewModel : INotifyPropertyChanged
    {
        private readonly CustomerRepository _repository;

        public event PropertyChangedEventHandler? PropertyChanged;

        //---------------------------------------------------------
        // Constructor
        //---------------------------------------------------------

        public CustomerViewModel(CustomerRepository repository)
        {
            _repository = repository;

            LoadCustomers();
        }

        //---------------------------------------------------------
        // Properties
        //---------------------------------------------------------

        public ObservableCollection<CustomerModel> Customers { get; }
            = new();

        private CustomerModel? _selectedCustomer;

        public CustomerModel? SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;
                OnPropertyChanged();
            }
        }

        //---------------------------------------------------------
        // Load
        //---------------------------------------------------------

        public void LoadCustomers()
        {
            try
            {
                Customers.Clear();

                foreach (CustomerModel customer in _repository.GetAll())
                {
                    Customers.Add(customer);
                }
            }
            catch (Exception ex)
            {
                FileLogger.Log(
                    "CustomerViewModel.LoadCustomers",
                    ex);
            }
        }

        //---------------------------------------------------------
        // Save
        //---------------------------------------------------------

        /// <summary>
        /// Save customer.
        /// Insert when CustomerId == 0.
        /// Update when CustomerId > 0.
        /// </summary>
        public bool Save(CustomerModel customer)
        {
            try
            {
                if (customer == null)
                    throw new ArgumentNullException(nameof(customer));

                bool success;

                if (customer.CustomerId == 0)
                {
                    success = _repository.Insert(customer);
                }
                else
                {
                    success = _repository.Update(customer);
                }

                if (success)
                {
                    LoadCustomers();
                }

                return success;
            }
            catch (Exception ex)
            {
                FileLogger.Log(
                    "CustomerViewModel.Save",
                    ex);

                return false;
            }
        }

        //---------------------------------------------------------
        // Delete
        //---------------------------------------------------------

        public bool Delete(int customerId)
        {
            try
            {
                bool success =
                    _repository.Delete(customerId);

                if (success)
                {
                    LoadCustomers();
                }

                return success;
            }
            catch (Exception ex)
            {
                FileLogger.Log(
                    "CustomerViewModel.Delete",
                    ex);

                return false;
            }
        }

        //---------------------------------------------------------
        // Search
        //---------------------------------------------------------

        public void Search(string keyword)
        {
            try
            {
                Customers.Clear();

                foreach (CustomerModel customer in _repository.Search(keyword))
                {
                    Customers.Add(customer);
                }
            }
            catch (Exception ex)
            {
                FileLogger.Log(
                    "CustomerViewModel.Search",
                    ex);
            }
        }

        //---------------------------------------------------------
        // Refresh
        //---------------------------------------------------------

        public void Refresh()
        {
            LoadCustomers();
        }

        //---------------------------------------------------------
        // Notify
        //---------------------------------------------------------

        protected virtual void OnPropertyChanged(
            [CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}