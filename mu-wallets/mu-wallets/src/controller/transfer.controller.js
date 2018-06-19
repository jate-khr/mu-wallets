var transferCrtl = function ($scope,$state, $stateParams, $log, dataFactory) {
    var ctrl = this;
    ctrl.Transfer = function (accountNo, amount) {
        dataFactory.Account.Transfer(accountNo, amount).then(function (data) {
            $state.transitionTo("transferResult");
            //ctrl.account.accountNo = data.accountNo;
            //ctrl.account.transfer = data.transfer;
            //ctrl.account.updateDate = data.updateDate;
        });
    }

}
transferCrtl.$inject = ['$scope',  '$state' ,'$stateParams', '$log', 'dataFactory'];