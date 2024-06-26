﻿using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsServices
    {
        IEnumerable<Actor> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}
