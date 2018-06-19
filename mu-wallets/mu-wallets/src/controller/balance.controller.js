var balanceCrtl = function ($scope, $stateParams, $log, dataFactory) {
    var ctrl = this;
    ctrl.user.accountNo = "123-456-789";
    ctrl.account = {
        accountNo: "",
        transfer: 0.00,
        updateDate : ""
    }
    dataFactory.Account.GetBal(ctrl.user.accountNo).then(function (data) {
        ctrl.account.accountNo = data.accountNo;
        ctrl.account.transfer = data.transfer;
        ctrl.account.updateDate = data.updateDate;
    });

}
balanceCrtl.$inject = ['$scope', '$stateParams', '$log', 'dataFactory'];