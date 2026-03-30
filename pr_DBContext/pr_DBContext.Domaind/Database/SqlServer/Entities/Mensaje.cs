using System;
using System.Collections.Generic;

namespace pr_DBContext.Domaind.Database.SqlServer.Entities;

public partial class Mensaje
{
    public int Id { get; set; }

    public Guid RemitenteId { get; set; }

    public Guid ReceiverId { get; set; }

    public string Content { get; set; } = null!;

    public bool IsRead { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Usuario Receiver { get; set; } = null!;

    public virtual Usuario Remitente { get; set; } = null!;
}
