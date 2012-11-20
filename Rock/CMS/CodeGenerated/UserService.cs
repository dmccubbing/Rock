//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//

using System;
using System.Linq;

using Rock.Data;

namespace Rock.Cms
{
    /// <summary>
    /// User Service class
    /// </summary>
    public partial class UserService : Service<User, UserDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class
        /// </summary>
        public UserService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class
        /// </summary>
        public UserService(IRepository<User> repository) : base(repository)
        {
        }

        /// <summary>
        /// Creates a new model
        /// </summary>
        public override User CreateNew()
        {
            return new User();
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public override IQueryable<UserDto> QueryableDto( )
        {
            return QueryableDto( this.Queryable() );
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public IQueryable<UserDto> QueryableDto( IQueryable<User> items )
        {
            return items.Select( m => new UserDto()
                {
                    ServiceType = m.ServiceType,
                    ServiceName = m.ServiceName,
                    UserName = m.UserName,
                    Password = m.Password,
                    IsConfirmed = m.IsConfirmed,
                    LastActivityDate = m.LastActivityDate,
                    LastLoginDate = m.LastLoginDate,
                    LastPasswordChangedDate = m.LastPasswordChangedDate,
                    CreationDate = m.CreationDate,
                    IsOnLine = m.IsOnLine,
                    IsLockedOut = m.IsLockedOut,
                    LastLockedOutDate = m.LastLockedOutDate,
                    FailedPasswordAttemptCount = m.FailedPasswordAttemptCount,
                    FailedPasswordAttemptWindowStart = m.FailedPasswordAttemptWindowStart,
                    ApiKey = m.ApiKey,
                    PersonId = m.PersonId,
                    Id = m.Id,
                    Guid = m.Guid,
                });
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( User item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }
}
