using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PeliculasAPI.Models;

public partial class Movie
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("premiere_year")]
    public short PremiereYear { get; set; }

    [Column("genre")]
    [StringLength(50)]
    [Unicode(false)]
    public string Genre { get; set; } = null!;

    [Column("director")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Director { get; set; }

    [Column("rating")]
    public byte Rating { get; set; }

    [Column("poster_url")]
    [StringLength(200)]
    [Unicode(false)]
    public string? PosterUrl { get; set; }

    [Column("oficial_trailer_url")]
    [StringLength(200)]
    [Unicode(false)]
    public string? OficialTrailerUrl { get; set; }
}
