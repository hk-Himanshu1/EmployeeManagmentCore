//const connection = new signalR.HubConnectionBuilder()
//    .withUrl("/SignalRControl")
//    .build();

//async function startConnection() {
//    try {
//        await connection.start();
//        console.log("SignalR connection established.");
//    } catch (err) {
//        console.error("SignalR connection failed: ", err);
//    }
//}

//async function sendValueToServer(value, val2) {
//    try {
//        await startConnection();
//        const serverResponse = await connection.invoke("SendMessage", value, val2);
//        console.log("Server response: ", serverResponse); 
//    } catch (err) {
//        console.error("Error invoking server method: ", err);
//    }
//}
//sendValueToServer("Value from client","hi");



const submitNewRegistration = () => {
    let newRegistration = {
        FName: $('#lblFirstName').val(),
        LName: $('#lblLastName').val(),
        Country: $('#ddlCountry').val(),
        Address: $('#lblAddress').val(),
        Email: $('#lblEmail').val(),
        State: $('#lblState').val(),
        Gender: $('#ddlGender').val(),
        UserType: $('#lblUserType').val(),
        PinCode: $('#lblPinCode').val(),
        UserName: $('#lblUsername').val(),
    };

    fetch('/Employee', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(newRegistration)
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json();
        })
        .then(data => {
            console.log('Success:', data);
        })
        .catch(error => {
            console.error('Error:', error);
        });
};


