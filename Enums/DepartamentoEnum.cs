using System.Text.Json.Serialization;

namespace WebAPI_CRUD_Funcionario.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum
    {
        Rh,
        Financeiro,
        Compras,
        Atendimento,
        Zeladoria
    }
}
