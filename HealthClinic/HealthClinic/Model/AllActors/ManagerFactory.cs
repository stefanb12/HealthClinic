// File:    ManagerFactory.cs
// Author:  Stefan
// Created: nedelja, 31. maj 2020. 19:56:45
// Purpose: Definition of Class ManagerFactory

using System;

namespace Model.AllActors
{
   public class ManagerFactory : UserFactory
   {
      public User CreateUser()
      {
         throw new NotImplementedException();
      }
   
   }
}