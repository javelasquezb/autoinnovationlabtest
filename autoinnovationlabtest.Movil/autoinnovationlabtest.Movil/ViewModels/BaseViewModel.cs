using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace autoinnovationlabtest.Movil.ViewModels
{
    /// <summary>
    /// Nombre de la clase: BaseViewModel
    /// Clase base para 
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged

    {
        //propiedad para el manejo de eventos de cambios en la propiedad 
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Metodo para realizar el cambio y reflejarlo en la vista
        /// </summary>
        /// <param name="propertyName">Nombre de la propiedad que esta realizando el cambio</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)

        {

            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));

        }


        /// <summary>
        /// Metodo para realizar el set value en la propiedad y mostrarlo en la vista
        /// </summary>
        /// <typeparam name="T">Parametro generico</typeparam>
        /// <param name="backingFieled">variable privada</param>
        /// <param name="value">varlo</param>
        /// <param name="propertyName">nombre de la propiedad (opcional)</param>
        protected void SetValue<T>(ref T backingFieled,T value,[CallerMemberName] string propertyName = null)

        {

            if (EqualityComparer<T>.Default.Equals(backingFieled,value))

            {

                return;

            }

            backingFieled = value;

            OnPropertyChanged(propertyName);

        }


        /// <summary>
        /// Metodo para realizar los cambios en el campo
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChangeds([CallerMemberName] string propertyName = null)

        {

            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)

            {

                handler(this,new PropertyChangedEventArgs(propertyName));

            }

        }

    }

}
