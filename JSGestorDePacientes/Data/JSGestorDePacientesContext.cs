using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JSGestorDePacientes.Models;

    public class JSGestorDePacientesContext : DbContext
    {
        public JSGestorDePacientesContext (DbContextOptions<JSGestorDePacientesContext> options)
            : base(options)
        {
        }

        public DbSet<JSGestorDePacientes.Models.JSCategoria> JSCategoria { get; set; } = default!;

public DbSet<JSGestorDePacientes.Models.JSPaciente> JSPaciente { get; set; } = default!;
    }
