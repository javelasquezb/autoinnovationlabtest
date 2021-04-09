using autoinnovationlabtest.Common.Models;
using Prism.Commands;
using System;

namespace autoinnovationlabtest.Movil.ViewModels
{
    public class CarItemViewModel : Car
    {
        #region Attributes
        private DelegateCommand _selectCarCommand;
        #endregion

        public CarItemViewModel()
        {

        }

        #region Properties
        #endregion

        #region Commands
        public DelegateCommand SelectCarCommand => _selectCarCommand ?? (_selectCarCommand = new DelegateCommand(SelectCar));


        #endregion

        #region Methods
        private void SelectCar()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
