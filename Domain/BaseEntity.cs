using System;

namespace appWebApi.Domain
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}
