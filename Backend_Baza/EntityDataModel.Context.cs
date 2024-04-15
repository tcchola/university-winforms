﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backend_Baza
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class UniversityEntities : DbContext
    {
        public UniversityEntities()
            : base("name=UniversityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Drzave> Drzaves { get; set; }
        public virtual DbSet<Gradovi> Gradovis { get; set; }
        public virtual DbSet<Korisnici> Korisnicis { get; set; }
        public virtual DbSet<Ocjene> Ocjenes { get; set; }
        public virtual DbSet<Predmeti> Predmetis { get; set; }
        public virtual DbSet<Profesori> Profesoris { get; set; }
        public virtual DbSet<ProfesoriPredmeti> ProfesoriPredmetis { get; set; }
        public virtual DbSet<Studenti> Studentis { get; set; }
    
        public virtual ObjectResult<Korisnici> Login(string username, string pssw)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var psswParameter = pssw != null ?
                new ObjectParameter("pssw", pssw) :
                new ObjectParameter("pssw", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Korisnici>("Login", usernameParameter, psswParameter);
        }
    
        public virtual ObjectResult<Korisnici> Login(string username, string pssw, MergeOption mergeOption)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var psswParameter = pssw != null ?
                new ObjectParameter("pssw", pssw) :
                new ObjectParameter("pssw", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Korisnici>("Login", mergeOption, usernameParameter, psswParameter);
        }
    
        public virtual ObjectResult<prikaz_gradova_cmbx_Result> prikaz_gradova_cmbx()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prikaz_gradova_cmbx_Result>("prikaz_gradova_cmbx");
        }
    
        public virtual ObjectResult<prikazi_podatke_profesora_Result> prikazi_podatke_profesora()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prikazi_podatke_profesora_Result>("prikazi_podatke_profesora");
        }
    
        public virtual int Register(string ime, string prezime, Nullable<System.DateTime> datumRodjenja, string email, string username, string pssw, Nullable<bool> isProf, Nullable<int> gradID)
        {
            var imeParameter = ime != null ?
                new ObjectParameter("ime", ime) :
                new ObjectParameter("ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("prezime", prezime) :
                new ObjectParameter("prezime", typeof(string));
    
            var datumRodjenjaParameter = datumRodjenja.HasValue ?
                new ObjectParameter("datumRodjenja", datumRodjenja) :
                new ObjectParameter("datumRodjenja", typeof(System.DateTime));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var psswParameter = pssw != null ?
                new ObjectParameter("pssw", pssw) :
                new ObjectParameter("pssw", typeof(string));
    
            var isProfParameter = isProf.HasValue ?
                new ObjectParameter("isProf", isProf) :
                new ObjectParameter("isProf", typeof(bool));
    
            var gradIDParameter = gradID.HasValue ?
                new ObjectParameter("gradID", gradID) :
                new ObjectParameter("gradID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Register", imeParameter, prezimeParameter, datumRodjenjaParameter, emailParameter, usernameParameter, psswParameter, isProfParameter, gradIDParameter);
        }
    
        public virtual int RegisterProfesori(string ime, string prezime, Nullable<System.DateTime> datumRodjenja, Nullable<int> gradID, string email, string zvanje)
        {
            var imeParameter = ime != null ?
                new ObjectParameter("ime", ime) :
                new ObjectParameter("ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("prezime", prezime) :
                new ObjectParameter("prezime", typeof(string));
    
            var datumRodjenjaParameter = datumRodjenja.HasValue ?
                new ObjectParameter("datumRodjenja", datumRodjenja) :
                new ObjectParameter("datumRodjenja", typeof(System.DateTime));
    
            var gradIDParameter = gradID.HasValue ?
                new ObjectParameter("gradID", gradID) :
                new ObjectParameter("gradID", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var zvanjeParameter = zvanje != null ?
                new ObjectParameter("zvanje", zvanje) :
                new ObjectParameter("zvanje", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegisterProfesori", imeParameter, prezimeParameter, datumRodjenjaParameter, gradIDParameter, emailParameter, zvanjeParameter);
        }
    
        public virtual int RegisterStudent(string ime, string prezime, Nullable<System.DateTime> datumRodjenja, Nullable<int> gradID, string email, string index)
        {
            var imeParameter = ime != null ?
                new ObjectParameter("ime", ime) :
                new ObjectParameter("ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("prezime", prezime) :
                new ObjectParameter("prezime", typeof(string));
    
            var datumRodjenjaParameter = datumRodjenja.HasValue ?
                new ObjectParameter("datumRodjenja", datumRodjenja) :
                new ObjectParameter("datumRodjenja", typeof(System.DateTime));
    
            var gradIDParameter = gradID.HasValue ?
                new ObjectParameter("gradID", gradID) :
                new ObjectParameter("gradID", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var indexParameter = index != null ?
                new ObjectParameter("index", index) :
                new ObjectParameter("index", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegisterStudent", imeParameter, prezimeParameter, datumRodjenjaParameter, gradIDParameter, emailParameter, indexParameter);
        }
    
        public virtual ObjectResult<prikazi_spisak_predmeta_studenta_Result> prikazi_spisak_predmeta_studenta()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prikazi_spisak_predmeta_studenta_Result>("prikazi_spisak_predmeta_studenta");
        }
    
        public virtual ObjectResult<prof_ocjenjivanja_Result> prof_ocjenjivanja(Nullable<int> profID)
        {
            var profIDParameter = profID.HasValue ?
                new ObjectParameter("profID", profID) :
                new ObjectParameter("profID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prof_ocjenjivanja_Result>("prof_ocjenjivanja", profIDParameter);
        }
    }
}
