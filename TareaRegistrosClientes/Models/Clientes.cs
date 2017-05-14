using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TareaRegistrosClientes.Models
{
    public class Clientes
    {
        [Key]

        public int ClienteId { get; set; }
        //[DataType(DataType.Text)]
        [StringLength(100)]
        [RegularExpression("^([a-zA-Z .&']+)$", ErrorMessage = "Solo letras")]
        [Required(ErrorMessage = "Debe ingresar el Nombre y Apellido.")]
        public string Nombres { get; set; }

        //[DataType(DataType.Text)]
        [StringLength(100)]
        [RegularExpression("^([a-zA-Z0-9 .&'-.&'#]+)$", ErrorMessage = "Caracteres invalidos")]
        [Required(ErrorMessage = "Debe ingresar la Direccion.")]
        public string Direccion { get; set; }

        //[DataType(DataType.PhoneNumber)]
        [StringLength(100)]
        [RegularExpression("^([0-9.&'-]+)$", ErrorMessage = "Solo Numeros y (-)")]
        [Required(ErrorMessage = "Debe ingresar el Telefono.")]
        public string Telefono { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime FechaCreacion { get; set; }

        //[DataType(DataType.EmailAddress)]
        [StringLength(100)]
        [RegularExpression("^([a-zA-Z0-9.&'_.&'@]+)$", ErrorMessage = "Caracteres invalidos")]
        [Required(ErrorMessage = "Debe ingresar ingresar el Email.")]
        public string Email { get; set; }

    }
}