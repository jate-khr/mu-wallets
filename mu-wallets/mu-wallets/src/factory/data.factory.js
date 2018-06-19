var dataFactory = function ($http, $q, $filtter) {
    var defer = $q.defer();
    return {
        Account: {
            GetBal: function (id) {
                $http({
                    method: 'GET',
                    url: '',

                    data: { accountNo: id }
                }).then(function (data) {
                    defer.resolve(data);
                });
                return defer.promise;
            },
            GetList: function () {
                return $q(function (resolve, reject) {
                    resolve(fakeDataHub.account);
                })
                
            },
            Find: function (id) {
                resolve($filtter('filter')(fakeDataHub.account, {id,id},true)[0])
            }
        }
       
    }
}

var fakeDataHub = {
    account: [{
        id: "123-456-789",
        amount: 2000.00,
        updateDate: "2016-06-19 14:29"
    },
    {
        id: "123-456-444",
        amount: 5000.00,
        updateDate: "2016-06-20 16:29"
    }
        ,
    {
        id: "123-456-555",
        amount: 6000.00,
        updateDate: "2016-06-21 10:29"
    }
    ]
}