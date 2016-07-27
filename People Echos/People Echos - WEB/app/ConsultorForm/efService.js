
(function (angular) {
app.factory('efService', ["$http",
    function ($http) {
       
        var dataLoad = {};
         return {
            query: function () {
                return $http.get('/Consultor/teste');
            },
            Submit: function (data, questaoCursosEDT, questaoSkillTema,questaoMercado) {
             
              return   $http({
                    method: 'POST',
                    url: '/Consultor/Cadastro',
                    data: {
                        model: data,
                        questaoCursosEDT: questaoCursosEDT,
                        questaoSkillTema: questaoSkillTema,
                        questaoMercado: questaoMercado
                    }
                })

            },
            getData: function () {
                
                return dataLoad;
            },
            setData: function (value) {
                dataLoad = value;
            },
            loadData: function () {
                dataLoad = $http.get('/Consultor/teste');
                return true;
            }
         };
  
    }]);
})(window.angular);