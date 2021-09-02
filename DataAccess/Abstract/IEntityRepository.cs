﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{

    //generic constraint
    //class:referans tip 
    //Ientity olabilir yada Ienitity implemente eden bir nesne olabilir


    public interface IEntityRepository<T> where T:class,IEntity,new()

    {

        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        

    }
}