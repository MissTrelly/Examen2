using System.ComponentModel.DataAnnotations;

namespace Examen2.Components.Data
{
    public class Producto
    {
        [Required(ErrorMessage = "El número de inventario es obligatorio")]
        [Range(1, long.MaxValue, ErrorMessage = "Debe ser un número entero positivo mayor a 0")]
        public long Inventario { get; set; } // Cambiado a long por el rango grande

        [Required(ErrorMessage = "El nombre no debe ser vacío")]
        [MaxLength(200, ErrorMessage = "El nombre no debe superar los 200 caracteres")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe seleccionar un departamento")]
        public string Departamento { get; set; } = string.Empty;
    }
}
