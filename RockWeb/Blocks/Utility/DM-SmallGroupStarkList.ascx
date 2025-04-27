<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DM-SmallGroupStarkList.ascx.cs" Inherits="RockWeb.Blocks.Utility.SmallGroupList" %>

<asp:UpdatePanel ID="upnlContent" runat="server">
    <ContentTemplate>

        <asp:Panel ID="pnlView" runat="server" CssClass="panel panel-block">
        
            <div class="panel-heading">
                <h1 class="panel-title">
                    <i class="fa fa-star"></i> 
                    Small Group List Block
                </h1>
            </div>
            <div class="panel-body">

                <div class="grid grid-panel">
                    <Rock:Grid ID="gList" runat="server" AllowSorting="true" OnRowSelected="gList_RowSelected">
                        <Columns>
                            <Rock:RockBoundField DataField="Name" HeaderText="Group Name" SortExpression="Name" />
                            <Rock:RockBoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                        </Columns>
                    </Rock:Grid>
                </div>

            </div>
        
        </asp:Panel>

    </ContentTemplate>
</asp:UpdatePanel>
