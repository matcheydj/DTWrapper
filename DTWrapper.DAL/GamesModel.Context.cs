﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;

namespace DTWrapper.POCO
{
    public partial class gamesEntities : ObjectContext
    {
        public const string ConnectionString = "name=gamesEntities";
        public const string ContainerName = "gamesEntities";
    
        #region Constructors
    
        public gamesEntities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public gamesEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public gamesEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<Game> Games
        {
            get { return _games  ?? (_games = CreateObjectSet<Game>("Games")); }
        }
        private ObjectSet<Game> _games;

        #endregion
    }
}
