'use strict';
//IIFE
(function () {
    document.getElementById('submit-btn').addEventListener('click', submitClick);

    function submitClick() {
        let _name = document.getElementById('name').value;
        let _family = document.getElementById('family').value;

        let msgDiv = document.createElement('div');
        msgDiv.setAttribute('class', 'alert alert-success');
        msgDiv.innerHTML = '<b>کاربر گرامی ' + _name + ' ' + _family + ' ثبت نام شما با موفقیت انجام شد' + '</b>';
        let msgContainer = document.getElementById('message-container');
        msgContainer.appendChild(msgDiv);
        //alert('سلام ' + _name + ' ' + _family);
    }
})();
