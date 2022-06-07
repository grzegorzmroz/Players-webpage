<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayerDetailsServer.aspx.cs" Inherits="Players_web.API.PlayerDetailsServer" %>

<div class="card">
    <input type="hidden" id="txtPlayerId" value="<%=ShownPlayer.player_id %>" />

              <div class="card-header">
                <h5 class="title">Edit Profile</h5>
              </div>
              <div class="card-body">
                <form>
                  <div class="row">
                    <div class="col-md-6 pl-1">
                      <div class="form-group">
                        <label>Name</label>
                        <input type="text" id="txtName" class="form-control" placeholder="Username" value="<%= ShownPlayer.name %>">
                      </div>
                    </div>
                     <div class="col-md-6 pl-1">
                      <div class="form-group">
                        <label>Surname</label>
                        <input type="text" id="txtSurname" class="form-control" placeholder="Username" value="<%= ShownPlayer.surname %>">
                      </div>
                    </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6 pl-1">
                      <div class="form-group">
                        <label>Nationality</label>
                        <input type="text" id="txtNationality" class="form-control" placeholder="Username" value="<%= ShownPlayer.nationality %>">
                      </div>
                    </div>
                     <div class="col-md-6 pl-1">
                      <div class="form-group">
                        <label>Birth Day</label>
                        <input type="text" id="txtBirthDate" class="form-control" placeholder="Username" value="<%= ShownPlayer.birth_date?.ToString("yyyy-MM-dd") %>">
                      </div>
                    </div>
                  </div>

                  <div class="row">
                     <div class="col-md-6 pl-1">
                      <div class="form-group">
                        <label>Weight</label>
                        <input type="text" id="txtWeight" class="form-control" placeholder="Username" value="<%= ShownPlayer.weight %>">
                      </div>
                    </div>
                     <div class="col-md-6 pl-1">
                      <div class="form-group">
                        <label>Height</label>
                        <input type="text" id="txtHeight" class="form-control" placeholder="Username" value="<%= ShownPlayer.height %>">
                      </div>
                    </div>
     
                  </div>

                    <input id="btnSave" type="button" value="Save" class="btn btn-primary btn-block">
                    
                    <input id="btnDelete" type="button" value="Delete" class="btn btn-primary btn-block">
                </form>
              </div>
            </div>
<script src="../JavaScripts/PlayerDetailsJS.js"></script>
