namespace Silva.Domain
{
    internal class AlquilerValidation
    {
        public static bool IsValid(Alquiler alquiler)
        {
            if (alquiler == null)
            {
                throw new Exception("Los datos del alquiler son requeridos.");
            }

            if (string.IsNullOrWhiteSpace(alquiler.Inquilino))
            {
                throw new Exception("El campo Inquilino es obligatorio.");
            }

            if (alquiler.MontoAlquiler < 0 || alquiler.MontoAlquiler > 1000000)
            {
                throw new Exception("El campo MontoAlquiler tiene que ser un valor comprendido entre 0 y 1.000.000.");
            }

            if (alquiler.FechaInicio >= alquiler.FechaFin)
            {
                throw new Exception("El campo FechaInicio debe ser inferior a la FechaFin.");
            }

            return true;
        }
    }
}
