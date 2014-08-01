using System;

namespace LanguageFeatures.PrimaryCtor
{
    public static class Throw
    {
        public static T IfNull<T>(string name, T argument) 
        {
            if(argument == null)
            {
                throw new ArgumentNullException(name);
            }
            return argument;
        }
    }

    public class AddUserCommand(User newUser, User creator)
    {
        public User NewUser { get; protected set; } = newUser;
        public User Creator { get; protected set; } = Throw.IfNull("creator", creator);
        public Guid CreatorId  { get; protected set; } = creator.Id;

        private User _newUser = newUser;
    }
}
