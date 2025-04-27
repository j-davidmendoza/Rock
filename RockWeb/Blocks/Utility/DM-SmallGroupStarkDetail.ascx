<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DM-SmallGroupStarkDetail.ascx.cs" Inherits="RockWeb.Blocks.Utility.SmallGroupDetails" %>

<asp:UpdatePanel ID="upnlContent" runat="server">
    <ContentTemplate>

        <asp:Panel ID="pnlView" runat="server" CssClass="panel panel-block">
        
            <div class="panel-heading">
                <h1 class="panel-title">
                    <i class="fa fa-star"></i> 
                    Small Group Detail Block
                </h1>

                <div class="panel-labels">
                    <Rock:HighlightLabel ID="hlblTest" runat="server" LabelType="Info" Text="Label" />
                </div>
            </div>
            <Rock:PanelDrawer ID="pdAuditDetails" runat="server"></Rock:PanelDrawer>
            <div class="panel-body">

                <div class="alert alert-info">
                    <h4>Small Group Block</h4>
                    <p>Things to know about this small group</p>
                </div>

                <div class="grid grid-panel">
                    <Rock:Grid ID="gList" runat="server" AllowSorting="true">
                        <Columns>
                            <Rock:RockBoundField DataField="Name" HeaderText="Group Name" SortExpression="Name" />
                            <Rock:RockBoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                            <Rock:RockBoundField DataField="CreatedDateTime" HeaderText="Date Created" SortExpression="CreatedDateTime" />
                            <Rock:RockBoundField DataField="ModifiedDateTime" HeaderText="Date Modified" SortExpression="ModifiedDateTime" />
                            <Rock:RockBoundField DataField="GroupCapacity" HeaderText="Group Capacity" SortExpression="GroupCapacity" />
                        </Columns>
                    </Rock:Grid>
                </div>

            </div>

        </asp:Panel>

    </ContentTemplate>
</asp:UpdatePanel>