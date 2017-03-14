using System;

namespace Argo.common.data.dtos
{
    public class AccessMatrixDto
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }
    }
}
