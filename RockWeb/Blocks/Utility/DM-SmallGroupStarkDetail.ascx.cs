// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.ComponentModel;
using System.Linq;
using System.Web.UI;
using Rock;
using Rock.Attribute;
using Rock.Model;

namespace RockWeb.Blocks.Utility
{

    [DisplayName( "Small Group Details" )]
    [Category( "Utility" )]
    [Description( "Basic details of a small group" )]

    #region Block Attributes

    #endregion Block Attributes
    [Rock.SystemGuid.BlockTypeGuid("e075ce1e-f9f2-4595-8384-e4b7ec2f45d5")]
    public partial class SmallGroupDetails : Rock.Web.UI.RockBlock
    {

        #region Attribute Keys

        #endregion Attribute Keys

        #region PageParameterKeys

        private static class PageParameterKey
        {
            public const string GroupId = "GroupId";
        }

        #endregion PageParameterKeys

        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Base Control Methods

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit( EventArgs e )
        {
            base.OnInit( e );

            this.BlockUpdated += Block_BlockUpdated;
            this.AddConfigurationUpdateTrigger( upnlContent );
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Load" /> event.
        /// </summary>
        /// <param name="e">The <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnLoad( EventArgs e )
        {
            if ( !Page.IsPostBack )
            {
                ShowDisplay();
            }

            base.OnLoad( e );
        }

        #endregion

        #region Events

        /// <summary>
        /// Handles the BlockUpdated event of the control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Block_BlockUpdated( object sender, EventArgs e )
        {

        }

        #endregion

        #region Methods

        private void ShowDisplay()
        {
            var rockContext = new Rock.Data.RockContext();
            var groupService = new GroupService(rockContext);

            int? groupId = PageParameter(PageParameterKey.GroupId).AsIntegerOrNull();

            var query = groupService.Queryable()
                .Select(g => new
                {
                    g.Id,
                    g.Name,
                    g.Description,
                    g.CreatedDateTime,
                    g.ModifiedDateTime,
                    g.GroupCapacity
                });

            if (groupId.HasValue)
            {
                query = query.Where(g => g.Id == groupId.Value);
            }

            var sortProperty = gList.SortProperty;
            if (sortProperty != null)
            {
                gList.DataSource = query.Sort(sortProperty).ToList();
            }
            else
            {
                gList.DataSource = query.OrderBy(g => g.Name).ToList();
            }

            gList.DataBind();
        }

        #endregion
    }
}