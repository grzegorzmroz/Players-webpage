<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayersServer.aspx.cs" Inherits="Players_web.API.PlayersServer" %>

<div class="card-body">
                <div class="table-responsive">
                  <table class="table">
                    <thead class=" text-primary">
                      <th>
                        Name and Surname
                      </th>
                      <th>
                        Nationality
                      </th>
                      <th>
                        Height
                      </th>
                      <th>
                        Birth Date
                      </th>
                    </thead>
                    <tbody>
                      
                        <% 
                            foreach (var p in Players)
                            {
                         %>
                        
                            <tr class="playerLink" data-id="<%=p.player_id %>"  id="player<%=p.player_id %>" >
                                <td>  <%= p.name + " " + p.surname %></td> 
                                <td><%= p.nationality %></td>
                                <td><%= p.height %></td>
                                <td><%= p.birth_date?.ToString("dd-MM-yyyy") %></td>
                            </tr>
                       

                         <% }
                            %>


                    </tbody>
                  </table>
                </div>
              </div>