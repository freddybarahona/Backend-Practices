namespace TalentInsights.Application.Models.Responses
{
    public class GenericResponse<T>
    {
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; } = DateTimeOffset.UtcNow.DateTime;//estandar que va a marcar la zona horaria universal, no la zona horaria local ya que DateTimeOffset se salta el paso de sacar la hora local
        public T Data { get; set; }

    }
}
