using System;
using System.Collections.Generic;

namespace pr_DBContext.Domaind.Database.SqlServer.Entities;

public partial class Usuario
{
    public Guid Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual ICollection<Mensaje> MensajeReceivers { get; set; } = new List<Mensaje>();

    public virtual ICollection<Mensaje> MensajeRemitentes { get; set; } = new List<Mensaje>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    public virtual ICollection<Seguidore> SeguidoreFollowers { get; set; } = new List<Seguidore>();

    public virtual ICollection<Seguidore> SeguidoreFollowings { get; set; } = new List<Seguidore>();
}
