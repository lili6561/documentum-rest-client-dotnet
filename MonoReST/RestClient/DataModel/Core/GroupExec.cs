﻿using Emc.Documentum.Rest.Net;
using Emc.Documentum.Rest.Http.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Emc.Documentum.Rest.DataModel
{
    public partial class Group
    {
        /// <summary>
        /// Get groups feed of which this group is a member
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="options"></param>
        /// <returns></returns>
        public Feed<T> GetParentGroups<T>(FeedGetOptions options)
        {
            return Client.GetFeed<T>(
                GetFullLinks(),
                LinkRelations.PARENT.Rel,
                options);
        }

        /// <summary>
        /// Get groups feed which are members of this group
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="options"></param>
        /// <returns></returns>
        public Feed<T> GetSubGroups<T>(FeedGetOptions options)
        {
            return Client.GetFeed<T>(
                GetFullLinks(),
                LinkRelations.GROUPS.Rel,
                options);
        }

        /// <summary>
        /// Get users feed which are members of this group
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="options"></param>
        /// <returns></returns>
        public Feed<T> GetGroupUsers<T>(FeedGetOptions options)
        {
            return Client.GetFeed<T>(
                GetFullLinks(),
                LinkRelations.USERS.Rel,
                options);
        }
    }
}
