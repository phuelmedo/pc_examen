using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planta_Negocio
{
    public class Planta : ObservableObject, IPersistente, IDataErrorInfo
    {
        public Dictionary<string, string> ErrorCollection { get; private set; } = new Dictionary<string, string>();
        public int Id { get; set; }
        public int IdUser { get; set; }

        private string _nombreComun;
        private string _nombreCientifico;
        private string _tipoPlanta;
        private string _descripcion;
        private int _tiempoRiego;
        private int _cantidadAgua;
        private string _epoca;
        private bool _esVenenosa;
        private bool _esAutoctona;
        private bool _datosValidos;
        private string _username;
        private string _password;
        public string Username
        {
            get { return _username; }
            set
            {
                OnPropertyChanged(ref _username, value);
            }
        }
        public string Password 
        {
            get { return _password; }
            set
            {
                OnPropertyChanged(ref _password, value);
            }
        }
        public string NombreComun
        {
            get { return _nombreComun; }
            set
            {
                OnPropertyChanged(ref _nombreComun, value);
            }
        }
        public string NombreCientifico
        {
            get { return _nombreCientifico; }
            set
            {
                OnPropertyChanged(ref _nombreCientifico, value);
            }
        }
        public string TipoPlanta
        {
            get { return _tipoPlanta; }
            set
            {
                OnPropertyChanged(ref _tipoPlanta, value);
            }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set
            {
                OnPropertyChanged(ref _descripcion, value);
            }
        }
        public int TiempoRiego
        {
            get { return _tiempoRiego; }
            set
            {
                OnPropertyChanged(ref _tiempoRiego, value);
            }
        }
        public int CantidadAgua
        {
            get { return _cantidadAgua; }
            set
            {
                OnPropertyChanged(ref _cantidadAgua, value);
            }
        }
        public string Epoca
        {
            get { return _epoca; }
            set
            {
                OnPropertyChanged(ref _epoca, value);
            }
        }
        public bool EsVenenosa
        {
            get { return _esVenenosa; }
            set
            {
                OnPropertyChanged(ref _esVenenosa, value);
            }
        }
        public bool EsAuctoctona
        {
            get { return _esAutoctona; }
            set
            {
                OnPropertyChanged(ref _esAutoctona, value);
            }
        }
        public string Error { get { return null; } }
        public bool DatosValidos
        {
            get { return _datosValidos; }
            set
            {
                if (_datosValidos != value)
                {
                    _datosValidos = value;
                    OnPropertyChanged(nameof(DatosValidos));
                }
            }
        }
        public string this[string name]
        {
            get
            {
                string res = null;
                switch (name)
                {
                    case "NombreComun":
                        if (string.IsNullOrEmpty(NombreComun))
                            res = "Nombre comun es obligatorio";
                        else if (NombreComun.Length < 3 || NombreComun.Length > 100)
                            res = "Nombre comun solo puede tener minimo 3 y maximo 100 caracteres";
                        break;

                    case "NombreCientifico":
                        if (string.IsNullOrEmpty(NombreCientifico))
                            res = "Nombre cientifico es obligatorio";
                        else if(NombreCientifico.Length < 10 || NombreCientifico.Length > 150)
                            res = "Nombre cientifico solo puede tener minimo 10 y maximo 150 caracteres";
                        break;

                    case "TipoPlanta":
                        if (string.IsNullOrEmpty(TipoPlanta))
                            res = "Tipo Planta obligatorio";
                        break;

                    case "TiempoRiego":
                        if (TiempoRiego == 0)
                            res = "Tiempo Riego debe ser mayor a 0";
                        break;

                    case "CantidadAgua":
                        if (CantidadAgua == 0)
                            res = "Cantidad Agua debe ser mayor a 0";
                        break;

                    case "Epoca":
                        if (string.IsNullOrEmpty(Epoca))
                            res = "Epoca obligatorio";
                        break;

                    case "Password":
                        if (string.IsNullOrEmpty(Password))
                            res = "Password obligatorio";
                        break;

                    case "Username":
                        if (string.IsNullOrEmpty(Username))
                            res = "Username obligatorio";
                        break;

                }
                if (ErrorCollection.ContainsKey(name))
                    ErrorCollection[name] = res;
                else if (res != null)
                    ErrorCollection.Add(name, res);

                DatosValidos = ErrorCollection.All(error => string.IsNullOrEmpty(error.Value));

                OnPropertyChanged(nameof(DatosValidos));

                return res;
            }
        }
        public bool Create()
        {
            try
            {

                CommonBC.ModelPlanta.spPlantaSave(
                    AES_Helper.EncryptString(this.NombreComun),
                    AES_Helper.EncryptString(this.NombreCientifico),
                    this.TipoPlanta,
                    AES_Helper.EncryptString(this.Descripcion),
                    this.TiempoRiego,
                    this.CantidadAgua,
                    this.Epoca,
                    this.EsVenenosa,
                    this.EsAuctoctona
                );

                CommonBC.ModelPlanta.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                CommonBC.ModelPlanta.spPlantaDeleteById(id);
                CommonBC.ModelPlanta.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Read(int id)
        {
            try
            {
                Planta_DALC.vwPlanta planta = CommonBC.ModelPlanta.vwPlanta.First(l => l.Id == id);

                this.Id = planta.Id;
                this.NombreComun = AES_Helper.DecryptString(planta.NombreComun);
                this.NombreCientifico = AES_Helper.DecryptString(planta.NombreCientifico);
                this.TipoPlanta = planta.TipoPlanta;
                this.Descripcion = AES_Helper.DecryptString(planta.Descripcion);
                this.TiempoRiego = planta.TiempoRiego;
                this.CantidadAgua = planta.CantidadAgua;
                this.Epoca = planta.Epoca;
                this.EsVenenosa = planta.EsVenenosa;
                this.EsAuctoctona = planta.EsAutoctona;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                CommonBC.ModelPlanta.spPlantaUpdateById(
                    this.Id,
                    AES_Helper.EncryptString(this.NombreComun),
                    AES_Helper.EncryptString(this.NombreCientifico),
                    this.TipoPlanta,
                    AES_Helper.EncryptString(this.Descripcion),
                    this.TiempoRiego,
                    this.CantidadAgua,
                    this.Epoca,
                    this.EsVenenosa,
                    this.EsAuctoctona
                );

                CommonBC.ModelPlanta.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ReadUser(string username, string password)
        {
            try
            {
                Planta_DALC.vwLogin login = CommonBC.ModelPlanta.vwLogin.First(l => l.Username == username);

                this.Username = login.Username;
                this.Password = AES_Helper.DecryptString(login.Password);

                if (password != Password)
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
