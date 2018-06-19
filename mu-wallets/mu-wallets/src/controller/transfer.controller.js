var transferCrtl = function ($scope, $stateParams, $log, dataFactory) {
    var ctrl = this;
    ctrl.Transfer = function (accountNo, amount) {
        dataFactory.Account.Transfer(ctrl.user.accountNo).then(function (data) {
            ctrl.account.accountNo = data.accountNo;
            ctrl.account.transfer = data.transfer;
            ctrl.account.updateDate = data.updateDate;
        });
    }

}
transferCrtl.$inject = ['$scope', '$stateParams', '$log', 'dataFactory'];