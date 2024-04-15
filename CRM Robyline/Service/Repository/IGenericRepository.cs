﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Robyline.Service.Repository
{
    interface IGenericRepository <TEntity> where TEntity : class
    {
        void Create(TEntity item);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Func<TEntity,bool> predicate);
        void Update(TEntity item);
        void Remove(TEntity item);
    }
}
