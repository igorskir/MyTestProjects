using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FormulaArtWPF.Annotations;

namespace FormulaArtWPF
{
    class MainWindowVm : INotifyPropertyChanged
    {
        private double _var_H;
        private double _var_h;
        private double _var_T;
        private double _var_t;
        private double _var_G;

        public MainWindowVm()
        {
            Var_H = 0;
            Var_h = 0;
            Var_T = 1;
            Var_t = 0;
        }

        public double Var_H
        {
            get
            {
                return _var_H;
            }
            set
            {
                _var_H = value;
                OnPropertyChanged(nameof(Var_H));
                OnPropertyChanged("Var_G");
            }
        }

        public double Var_h
        {
            get
            {
                return _var_h;
            }
            set
            {
                _var_h = value;
                OnPropertyChanged(nameof(Var_h));
                OnPropertyChanged("Var_G");
            }
        }

        public double Var_T
        {
            get
            {
                return _var_T;
            }
            set
            {
                _var_T = value;
                OnPropertyChanged(nameof(Var_T));
                OnPropertyChanged("Var_G");
            }
        }

        public double Var_t
        {
            get
            {
                return _var_t;
            }
            set
            {
                _var_t = value;
                OnPropertyChanged(nameof(Var_t));
                OnPropertyChanged("Var_G");
            }
        }

        public double Var_G
        {
            get
            {
                try
                {            
                    _var_G = (_var_H - _var_h) / (_var_T - _var_t);
                    return _var_G;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error is occure: {0}", exception.ToString());
                    return 0;
                }
            }
            set
            {
                _var_G = value;
                OnPropertyChanged(nameof(Var_G));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
