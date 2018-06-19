var balanceCrtl = function ($scope, $stateParams, $log, dataFactory) {
    var ctrl = this;
    ctrl.user = { accountNo: "123-456-789" };
    ctrl.account = {
        accountNo: "",
        amount: 0.00,
        updateDate : ""
    }
    dataFactory.Account.GetBal(ctrl.user.accountNo).then(function (data) {
        ctrl.account.accountNo = data.data.accountNo;
        ctrl.account.amount = data.data.amount;
        ctrl.account.updateDate = '17-06-2561 14:29';
    });

}
balanceCrtl.$inject = ['$scope', '$stateParams', '$log', 'dataFactory'];