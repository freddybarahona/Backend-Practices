namespace Ejercicio.Shared.Constants
{
    public class ValidationConstants
    {
        public const string MAX_LENGTH = "el {0} requiere maximo {1} caracteres";
        public const string MIN_LENGTH = "el {0} requiere minimo {1} caracteres";
        public const string REQUIRED = "este campo {0} es requerido ";
        //los atributos como [MaxLength],[Required],etc en appplication
        //no usan estas propiedades a menos que sean const "osea que nunca cambien"
        //si no lo pones el const te dara error

        //y ese {0} esta aqui para que use el valor en la application de esta forma
        //[MaxLength(90, ErrorMessage = ValidationConstants.MAX_LENGTH)]
        //                          |es igual a|
        //[MaxLength(90, ErrorMessage = "el maximo de caracteres es {0}")]
        //                          |es igual a| 
        //[MaxLength(90, ErrorMessage = "el maximo de caracteres es 90")]

        //osea ese 0 llama al nommbre de la propiedad en esa posicion 0 osea UserName
        //y 1 llama al valor de MaxLength
    }
}
