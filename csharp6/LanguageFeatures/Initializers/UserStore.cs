using System;
using System.Collections;
using System.Collections.Generic;

namespace LanguageFeatures.Initializers
{
    public static class UserExtensions
    {
        public static User Add(this UserStore store, User newUser)
        {
            store.Persist(newUser);
            return newUser;
        }
    }

    public class UserStore : IEnumerable<User>
    {
        public User Persist(User newUser)
        {
            _users.Add(newUser);
            if (UserAdded != null)
            {
                UserAdded(this, new EventArgs());
            }
            return newUser;
        }

        public IEnumerator<User> GetEnumerator()
        {
            return _users.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public event EventHandler<EventArgs> UserAdded;
        List<User> _users = new List<User>();
    }
}
