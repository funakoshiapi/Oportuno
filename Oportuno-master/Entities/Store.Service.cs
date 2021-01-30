using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Oportuno.Entities
{
    public partial class Store
    {
        
        public enum ServiceType
        {
            None,
            Barbearia,
            Salao,
            Massagem,
            Estetica,
            Dentista,
            Judicial,
            [Description("Personal Trainer")]
            Pesonal_Trainer,
            Yoga,

        }
    }

}