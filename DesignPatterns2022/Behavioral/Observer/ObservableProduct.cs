﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Behavioral.Observer
{
    // Takip edilecek olan yapımızdır.
    // İçerisinde Observer (değişimden etkilenecek) nesneleri tutar.
    abstract class ObservableProduct
    {
        private List<IObserverUser> _users;
        protected ProductUpdateMessage message;

        public ObservableProduct()
        {
            _users = new List<IObserverUser>();
            message = new ProductUpdateMessage();
        }

        public void AddObserver(IObserverUser observerUser)
        {
            _users.Add(observerUser);
        }
        public void RemoveObserver(IObserverUser observerUser)
        {
            _users.Remove(observerUser);
        }
        public void NotifyObserver()
        {
            foreach (IObserverUser user in _users)
            {
                user.SendNotification(message);
            }
        }
    }
}
