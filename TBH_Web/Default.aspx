<%@ Page 
    Title="The Beer House"
    Language="C#" 
    AutoEventWireup="true" 
    CodeFile="Default.aspx.cs" 
    Inherits="_Default" 
%>

<asp:Content 
    ID="Content1" 
    ContentPlaceHolderID="RightContent" 
    Runat="Server">
</asp:Content>

<asp:Content 
    ID="Content2" 
    ContentPlaceHolderID="MainContent" 
    Runat="Server">
    <asp:Image 
        ID="imgBeers" 
        runat="server" 
        ImageUrl="~/images/3beers.jpg" 
        ImageAlign="Left" 
        hspace="8" 
        AlternateText="3 beers" 
    />
    Lorem ipsum dolor sit amet, consectetuer adipiscing elit...
</asp:Content>

<asp:Content 
    ID="Content3" 
    ContentPlaceHolderID="LeftContent" 
    Runat="Server">
</asp:Content>

