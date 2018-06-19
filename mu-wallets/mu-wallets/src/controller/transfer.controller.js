var transferCrtl = function ($scope, $state, $stateParams, $log, dataFactory, $rootScope) {
    var ctrl = this;
    ctrl.Transfer = function (accountNo, amount) {
        dataFactory.Account.Transfer(accountNo, ctrl.receiveAccount, amount).then(function (data) {
            //$state.transitionTo("transferResult");
            //cons
            $rootScope.transfer_result = data.data;
            $rootScope.StateRoute('transferResult', {
                accountNo: accountNo,
                accountReceive: ctrl.receiveAccount,
                amount: amount
            });
            //ctrl.account.accountNo = data.accountNo;
            //ctrl.account.transfer = data.transfer;
            //ctrl.account.updateDate = data.updateDate;
        });
    }

}
transferCrtl.$inject = ['$scope',  '$state' ,'$stateParams', '$log', 'dataFactory', '$rootScope'];