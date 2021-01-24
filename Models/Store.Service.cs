using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Oportuno.Models
{
    public partial class Store
    {
        [Required]
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