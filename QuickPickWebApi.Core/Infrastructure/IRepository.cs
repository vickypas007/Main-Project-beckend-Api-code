﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickPickWebApi.Core.Infrastructure
{
    public interface IRepository<T> : IGetRepository<T>, IDisposable where T : class
    {
        void Add(T entity);
        void Add(params T[] entities);
        void Add(IEnumerable<T> entities);


        void Delete(T entity);
        void Delete(object id);
        void Delete(params T[] entities);
        void Delete(IEnumerable<T> entities);


        void Update(T entity);
        void Update(params T[] entities);
        void Update(IEnumerable<T> entities);



    }
}
