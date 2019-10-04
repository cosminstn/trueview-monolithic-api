using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueViewMonolithAPI.Authentication {
    public class AuthenticationService {

        private FirebaseAuthManagement authService;

        private static readonly Lazy<AuthenticationService> lazy = new Lazy<AuthenticationService>(() => new AuthenticationService());

        public static AuthenticationService Instance { get { return lazy.Value; } }

        private AuthenticationService() {
            authService = new FirebaseAuthManagement();
        }



    }
}
