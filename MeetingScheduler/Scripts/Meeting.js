
function initialize()
{
    $('.month').click(function () {       
        SelectMonth(this.id);
        GetMappingByMonth(this);
    });
}
  
function GetMappingByMonth(ref) {  
    Loader();
    $("#divMeetings").html('');
    $("#divMeetings").hide();    
    var html = '';
    $.ajax({
        type: 'GET',
        url: GetMappingURL,        
        data: { Month: ref.id},
        dataType: "json",
        success: function (result) { 
            $.each(result, function (i, item) {                  
                var nowDate = new Date(parseInt(item.Date.substr(6)));                
                html = '<div>' + dateFormat(nowDate, "m/dd/yy  h:MM TT") + ' <a onclick="javascript: GetMappingDetail(\'' + item.MeetingId + '\',\'' + item.Description + '\',\'' + item.Organizer + '\',\'' + dateFormat(nowDate, "m/dd/yy") + '\');">' + item.Title + '</a> </div>';
                $("#divMeetings").append(html);
                $("#divMeetings").show();
                LoaderHide();
            });           
        },
        error: function () {
            LoaderHide();
        }
    }); 
}

function GetMappingDetail(id,description,organizer,date) {
    Loader();
    $("#divMeetingDetail").html('');
    $("#divMeetingDetail").hide();    
    var attendes = '';
    var html = '<div>Description:' + description + '</div><div>Date:' + date + '</div><div>Organizer:' + organizer +'</div><div>Attendee<ul>';
    $.ajax({
        type: 'GET',
        url: GetMappingDetailURL,
        data: { MeetingId: id },
        dataType: "json",
        success: function (result) {
            $.each(result, function (i, item) { 
                attendes += '<li>'+item.Attendee+'</li>';
            });
            html += attendes + '</ul></div>';
            $("#divMeetingDetail").append(html);
            $("#divMeetingDetail").show();
            LoaderHide();
        },
        error: function () {
            LoaderHide();
        }
    });
}

function SelectMonth(id) {
    $('.month').each(function () {
        $(this).removeClass("btn-primary");
    });
    var ident = "#" + id;
    $(ident).addClass("btn-primary");
}

function Loader()
{
    $("#Loader").text('');
    $("#Loader").append("<div class='modal' id='loading'><div class='center'>Please Wait ...<br /><img src='/Images/loading42.gif'/></div></div>");
    $('#loading').show();
}
function LoaderHide() {    
    $('#loading').hide();
}
