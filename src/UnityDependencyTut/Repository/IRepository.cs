﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDependencyTut.Repository
{
  public interface IRepository<T> where T : class
  {
    IEnumerable<T> GetAll();
    T GetById(object id);
  }
}
