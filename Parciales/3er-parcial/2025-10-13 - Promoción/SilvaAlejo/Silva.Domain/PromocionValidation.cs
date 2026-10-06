namespace Silva.Domain
{
    internal class PromocionValidation
    {
        public static bool IsValid(Promocion promocion)
        {
            if (promocion == null)
            {
                throw new Exception("Los datos de la promoción son requeridos.");
            }

            if (string.IsNullOrWhiteSpace(promocion.Nombre))
            {
                throw new Exception("El campo Nombre es obligatorio.");
            }

            if (promocion.Descuento < 1 || promocion.Descuento > 100)
            {
                throw new Exception("El campo Descuento tiene que ser un valor comprendido entre 1 y 100.");
            }

            if (promocion.FechaInicio >= promocion.FechaFin)
            {
                throw new Exception("El campo FechaInicio debe ser inferior a la FechaFin.");
            }

            if (promocion.Estado != "Activa" && promocion.Estado != "Expirada")
            {
                throw new Exception("El campo Estado debe ser Activa o Expirada.");
            }

            return true;
        }
    }
}
